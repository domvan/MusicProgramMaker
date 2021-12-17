<!-- Creates a connection to the database -->
<?php
   include "Connect.php";
   ?>
<!-- -------------------------------------- -->

<!DOCTYPE HTML>
<html>
  <!-- Header for Tab -->
   <head>
      <title>Manage Classes</title>
      <meta http-equiv="Content-Type" content="text/html; charset=iso=8859-1">
      <link rel="stylesheet" type="text/css" href="style.css">
   </head>
     <!-- Start of Body -->
   <body>
   <a href="AdminLandingPage.php">&#8592 Back</a>
      <center>
         <!-- Populates with an image at the top and will take you back to the default view (not searched) if clicked -->
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManageClasses.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
            <!-- Search Form -->
            <h2> Search Classes </h2>
            <form action ="ManageClasses.php" method="GET">
               <input type="text" name="search" placeholder="What are you looking for?"/> <!-- name is used to determine the query block below -->
               <input type="submit" value="Search"/>
            </form>
         </div>
         <!-- Add New Class Form -->
         <h2 class="header"> Add New Class </h2>
         <form action ="ManageClasses.php" method="POST">
            <label for="text">Class ID:</label>
            <input type="text" name="classID" placeholder="Class ID" maxlength="6">
            <label for="text">
               Teacher:
               <select name="tID">
                  <!-- Gets all composers from the database and then adds them to the drop down of selectable values -->
                  <?php 
                     $sql = mysqli_query($connection, "SELECT name, tID FROM teacher");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['tID'].'"> '.$row['name'].' </option>';
                     }
                     ?>
                  <!-- Finish getting the composers -->
               </select>
            </label>
            <input type = "submit" name = "insertClass" value = "Add"> 
         </form>
         <!-- Finish Add New Class Form-->
         <br>
         </br>
         <!-- Classes Data Table -->
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                 <!-- Classes Data Table Headers (Probably could get these from the database if necessary similar to the composer names) -->
                  <th>Class ID</th>
                  <th>Teacher</th>
                  <th>School</th>
                  <th>Actions</th>
               </tr>
               <?php
                  // If the user clicks on the "Add" button then this query will be executed. NOTE: There is no field for data so I just added 2021 as a default but this could be left blank              
                  if(isset($_POST["insertClass"])) {
                     mysqli_query($connection, "INSERT into class VALUES ('$_POST[classID]', NULL, '$_POST[tID]')");
                     printf("Error: %s\n", $connection -> error);
                  }
                  
                  // If the user clicks on the "search" button then this query will be executed and the page will be reloaded with the following query.
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM class, teacher WHERE (class.tID = teacher.tID) AND (name LIKE '%$search%' or school LIKE '%$search%' or classID LIKE '$search')";
                    
                    // Assuming there was some result then we need to build the table
                    if(mysqli_query($connection, $query))
                    {
                    $result = mysqli_query($connection, $query);
                      while($class=mysqli_fetch_assoc($result)) {
                      
                        echo "<tr>";
                      
                        echo "<td>".$class['classID']."</td>";
  
                        echo "<td>".$class['name']."</td>";
  
                        echo "<td>".$class['school']."</td>";
                        
                        echo "<td><a href=DeleteClass.php?id=".str_replace(" ","+",$class['classID']).">Delete</a>
                         &nbsp <a href=ManageClass.php?id=".str_replace(" ","+",$class['classID']).">Manage Students</a></td>";
                        
                        echo "</tr>";
                              
                      }
                    }
                  }	else { // If there was not a search and the page was just loaded fresh then all results should be shown
                    $query = "SELECT * FROM class, teacher WHERE class.tID = teacher.tID";
                    $result = mysqli_query($connection, $query);
                    
                    while($class=mysqli_fetch_assoc($result)) {
                      echo "<tr>";
                      
                      echo "<td>".$class['classID']."</td>";

                      echo "<td>".$class['name']."</td>";

                      echo "<td>".$class['school']."</td>";
                      
                      echo "<td><a href=DeleteClass.php?id=".str_replace(" ","+",$class['classID']).">Delete</a>
                       &nbsp <a href=ManageClass.php?id=".str_replace(" ","+",$class['classID']).">Manage Students</a></td>";
                      
                      echo "</tr>";
                    }
                  }
                ?>
            </table>
         </div>
      </center>
   </body>
</html>