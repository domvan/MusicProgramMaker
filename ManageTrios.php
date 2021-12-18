<!-- Creates a connection to the database -->
<?php
   include "Connect.php";
   ?>
<!-- -------------------------------------- -->

<!DOCTYPE HTML>
<html>
  <!-- Header for Tab -->
   <head>
      <title>Manage Trios</title>
      <meta http-equiv="Content-Type" content="text/html; charset=iso=8859-1">
      <link rel="stylesheet" type="text/css" href="style.css">
   </head>
     <!-- Start of Body -->
   <body>
   <a href="AdminLandingPage.php">&#8592 Back</a>
      <center>
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManageTrios.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
            <h2> Search Trios </h2>
            <form action ="ManageTrios.php" method="GET">
               <input type="text" name="search" placeholder="Search for trios"/>
               <input type="submit" value="Search"/>
            </form>
         </div>
         <h2 class="header"> Add New Trio </h2>
         <form action ="ManageTrios.php" method="POST">
            <label for="text">
               Violinist:
               <select name="violinist">
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
               <select name="pianist">
                  <?php 
                     $sql = mysqli_query($connection, "SELECT name FROM pianist");
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
            <input type = "submit" name = "insertTrio" value = "Add"> 
         </form>
         <br>
         </br>
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                  <th>Violinist</th>
                  <th>Cellist</th>
                  <th>Pianist</th>
                  <th>Age</th>
                  <th>Bio</th>
                  <th>Actions</th>
               </tr>
               <?php           
                  if(isset($_POST["insertTrio"])) {
                     $front_violinist = substr($_POST["violinist"], 0, 2);
                     $front_cellist = substr($_POST["cellist"], 0, 2);
                     $front_pianist = substr($_POST["pianist"], 0, 2);
                     $gID = $front_violinist . $front_cellist . $front_pianist;
                     mysqli_query($connection, "INSERT into team VALUES ('$gID', '$_POST[age]', '$_POST[bio]')");
                     mysqli_query($connection, "INSERT into trio VALUES ('$gID', '$_POST[violinist]', '$_POST[cellist]', '$_POST[pianist]')");
                  }
                  
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM trio, team WHERE (trio.gID = team.gID) AND (violin LIKE '%$search%' or cello LIKE '%$search%' or piano LIKE '%$search%')";
                    
                    if(mysqli_query($connection, $query))
                    {
                    $result = mysqli_query($connection, $query);
                      while($trio=mysqli_fetch_assoc($result)) {
                      
                        echo "<tr>";
                      
                        echo "<td>".$trio['violin']."</td>";
                        
                        echo "<td>".$trio['cello']."</td>";
                        
                        echo "<td>".$trio['piano']."</td>";

                        echo "<td>".$trio['age']."</td>";

                        echo "<td>".$trio['bio']."</td>";
                        
                        echo "<td><a href=DeleteTrio.php?id=".str_replace(" ","+",$trio['gID']).">Delete</a></td>";
                        
                        echo "</tr>";	
                              
                      }
                    }
                  }	else {
                    $query = "SELECT * FROM trio, team WHERE trio.gID = team.gID";
                    $result = mysqli_query($connection, $query);
                    
                    while($trio=mysqli_fetch_assoc($result)) {
                     echo "<tr>";
                      
                     echo "<td>".$trio['violin']."</td>";
                     
                     echo "<td>".$trio['cello']."</td>";
                     
                     echo "<td>".$trio['piano']."</td>";

                     echo "<td>".$trio['age']."</td>";

                     echo "<td>".$trio['bio']."</td>";
                     
                     echo "<td><a href=DeleteTrio.php?id=".str_replace(" ","+",$trio['gID']).">Delete</a></td>";
                     
                     echo "</tr>";	
                    }
                  }
                ?>
            </table>
         </div>
      </center>
   </body>
</html>