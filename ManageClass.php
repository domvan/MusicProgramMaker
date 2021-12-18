<!-- Creates a connection to the database -->
<?php
   include "Connect.php";
   ?>
<!-- -------------------------------------- -->

<!DOCTYPE HTML>
<html>
  <!-- Header for Tab -->
   <head>
      <title>Manage Class</title>
      <meta http-equiv="Content-Type" content="text/html; charset=iso=8859-1">
      <link rel="stylesheet" type="text/css" href="style.css">
   </head>
     <!-- Start of Body -->
   <body>
   <a href="ManageClasses.php">&#8592 Back</a>
      <center>
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManageClasses.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
         </div>
         <?php
         $id = str_replace("+"," ",$_GET['id']);
         echo "<h2 class='header'> Add Student to ".$id."</h2>";
         echo "<form action ='ManageClass.php?id=".$id."' method='POST'>"
         ?>
            <label for="text">
               Student:
               <select name="sName">
                  <?php 
                     $sql = mysqli_query($connection, "SELECT name FROM performer WHERE classID IS NULL");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['name'].'"> '.$row['name'].' </option>';
                     }
                     ?>
               </select>
            </label>
            <input type = "submit" name = "insertClass" value = "Add"> 
         </form>
         <br>
         </br>
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                  <th>Name</th>
                  <th>Actions</th>
               </tr>
               <?php            
                  $id = str_replace("+"," ",$_GET['id']);
                  if(isset($_POST["insertClass"])) {
                     mysqli_query($connection, "UPDATE performer SET classID = '$id' WHERE name = '$_POST[sName]'");
                  }
                  $query = "SELECT * FROM performer WHERE classID = '$id'";
                  $result = mysqli_query($connection, $query);
                  
                  while($class=mysqli_fetch_assoc($result)) {
                     echo "<tr>";

                     echo "<td>".$class['name']."</td>";
                     
                     echo "<td><a href=RemoveFromClass.php?performer=".str_replace(" ","+",$class['name']).">Unenroll</a></td>";
                     
                     echo "</tr>";
                  }
                ?>
            </table>
         </div>
      </center>
   </body>
</html>