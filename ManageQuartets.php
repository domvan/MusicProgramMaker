<!-- Creates a connection to the database -->
<?php
   include "Connect.php";
   ?>
<!-- -------------------------------------- -->

<!DOCTYPE HTML>
<html>
  <!-- Header for Tab -->
   <head>
      <title>Manage Quartets</title>
      <meta http-equiv="Content-Type" content="text/html; charset=iso=8859-1">
      <link rel="stylesheet" type="text/css" href="style.css">
   </head>
     <!-- Start of Body -->
   <body>
   <a href="AdminLandingPage.php">&#8592 Back</a>
      <center>
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManageQuartets.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
            <h2> Search Quartets </h2>
            <form action ="ManageQuartets.php" method="GET">
               <input type="text" name="search" placeholder="Search for quartets"/>
               <input type="submit" value="Search"/>
            </form>
         </div>
         <h2 class="header"> Add New Quartet </h2>
         <form action ="ManageQuartets.php" method="POST">
            <label for="text">
               First Violinist:
               <select name="violinist1">
                  <?php 
                     $sql = mysqli_query($connection, "SELECT name FROM violinist");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['name'].'"> '.$row['name'].' </option>';
                     }
                     ?>
               </select>
            </label>
            <label for="text">
               Second Violinist:
               <select name="violinist2">
                  <?php 
                     $sql = mysqli_query($connection, "SELECT name FROM violinist");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['name'].'"> '.$row['name'].' </option>';
                     }
                     ?>
               </select>
            </label>
            <label for="text">
               Cellist:
               <select name="cellist">
                  <?php 
                     $sql = mysqli_query($connection, "SELECT name FROM cellist");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['name'].'"> '.$row['name'].' </option>';
                     }
                     ?>
               </select>
            </label>
            <label for="text">
               Pianist:
               <select name="violist">
                  <?php 
                     $sql = mysqli_query($connection, "SELECT name FROM violist");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['name'].'"> '.$row['name'].' </option>';
                     }
                     ?>
               </select>
            </label>
            <label for="text">Age:</label>
            <input type="text" name="age" placeholder="Age">
            <label for="text">Bio:</label>
            <input type="text" name="bio" placeholder="Bio">
            <input type = "submit" name = "insertQuartet" value = "Add"> 
         </form>
         <br>
         </br>
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                  <th>First Violinist</th>
                  <th>Second Violinist</th>
                  <th>Cellist</th>
                  <th>Violist</th>
                  <th>Age</th>
                  <th>Bio</th>
                  <th>Actions</th>
               </tr>
               <?php          
                  if(isset($_POST["insertQuartet"])) {
                     $front_violinist1 = substr($_POST["violinist1"], 0, 1);
                     $front_violinist2 = substr($_POST["violinist2"], 0, 1);
                     $front_cellist = substr($_POST["cellist"], 0, 1);
                     $front_violist = substr($_POST["violist"], 0, 1);
                     $front_age = substr($_POST["age"], 0, 1);
                     $gID = $front_violinist1 . $front_violinist1. $front_cellist . $front_violist . $front_age;
                     echo $gID;
                     mysqli_query($connection, "INSERT into team VALUES ('$gID', '$_POST[age]', '$_POST[bio]')");
                     mysqli_query($connection, "INSERT into quartet VALUES ('$gID', '$_POST[violinist1]', '$_POST[violinist2]', '$_POST[cellist]', '$_POST[violist]')");
                  }
                  
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM quartet, team WHERE quartet.gID = team.gID AND (firstViolin LIKE '%$search%' or secondViolin LIKE '%$search%' or cello LIKE '%$search%' or viola LIKE '%$search%')";
                    
                    if(mysqli_query($connection, $query))
                    {
                    $result = mysqli_query($connection, $query);
                      while($quartet=mysqli_fetch_assoc($result)) {
                      
                        echo "<tr>";
                      
                        echo "<td>".$quartet['firstViolin']."</td>";

                        echo "<td>".$quartet['secondViolin']."</td>";
                        
                        echo "<td>".$quartet['cello']."</td>";
                        
                        echo "<td>".$quartet['viola']."</td>";

                        echo "<td>".$quartet['age']."</td>";

                        echo "<td>".$quartet['bio']."</td>";
                        
                        echo "<td><a href=DeleteQuartet.php?id=".str_replace(" ","+",$quartet['gID']).">Delete</a></td>";
                        
                        echo "</tr>";	
                              
                      }
                    }
                  }	else {
                    $query = "SELECT * FROM quartet, team WHERE quartet.gID = team.gID";
                    $result = mysqli_query($connection, $query);
                    
                    while($quartet=mysqli_fetch_assoc($result)) {
                     echo "<tr>";
                      
                     echo "<td>".$quartet['firstViolin']."</td>";

                     echo "<td>".$quartet['secondViolin']."</td>";
                     
                     echo "<td>".$quartet['cello']."</td>";
                     
                     echo "<td>".$quartet['viola']."</td>";

                     echo "<td>".$quartet['age']."</td>";

                     echo "<td>".$quartet['bio']."</td>";
                     
                     echo "<td><a href=DeleteQuartet.php?id=".str_replace(" ","+",$quartet['gID']).">Delete</a></td>";
                     
                     echo "</tr>";
                    }
                  }
                ?>
            </table>
         </div>
      </center>
   </body>
</html>