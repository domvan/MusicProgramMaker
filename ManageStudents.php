<!-- Creates a connection to the database -->
<?php
   include "Connect.php";
   ?>
<!-- -------------------------------------- -->

<!DOCTYPE HTML>
<html>
  <!-- Header for Tab -->
   <head>
      <title>Manage Students</title>
      <meta http-equiv="Content-Type" content="text/html; charset=iso=8859-1">
      <link rel="stylesheet" type="text/css" href="style.css">
   </head>
     <!-- Start of Body -->
   <body>
   <a href="AdminLandingPage.php">&#8592 Back</a>
      <center>
         <!-- Populates with an image at the top and will take you back to the default view (not searched) if clicked -->
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManageStudents.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
            <!-- Search Form -->
            <h2> Search Students </h2>
            <form action ="ManageStudents.php" method="GET">
               <input type="text" name="search" placeholder="Search for students"/> <!-- name is used to determine the query block below -->
               <input type="submit" value="Search"/>
            </form>
         </div>
         <!-- Add New Student Form -->
         <h2 class="header"> Add New Student </h2>
         <form action ="ManageStudents.php" method="POST">
            <label for="text">Name:</label>
            <input type="text" name="name" placeholder="Student Name">
            <label for="text">Age:</label>
            <input type="text" name="age" placeholder="Age">
            <label for="text">Bio:</label>
            <input type="text" name="bio" placeholder="Bio">
            <label for="text">
               Class:
               <select name="className">
               <option value='NULL'>No Class</option>
                  <!-- Gets all composers from the database and then adds them to the drop down of selectable values -->
                  <?php 
                     $sql = mysqli_query($connection, "SELECT classID FROM class");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['classID'].'"> '.$row['classID'].' </option>';
                     }
                     ?>
                  <!-- Finish getting the composers -->
               </select>
            </label>
            <label for="text">
               Level:
               <select name="levelID">
                  <!-- Gets all composers from the database and then adds them to the drop down of selectable values -->
                  <?php 
                     $sql = mysqli_query($connection, "SELECT levelID FROM level");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['levelID'].'"> '.$row['levelID'].' </option>';
                     }
                     ?>
                  <!-- Finish getting the composers -->
               </select>
            </label>
            <label for="text">
               Instrument:
               <select name="instrument">
               <option value="cellist">Cellist</option>';
               <option value="pianist">Pianist</option>';
               <option value="violinist">Violinist</option>';
               <option value="violist">Violist</option>';
               </select>
            </label>
            <input type = "submit" name = "insertStudent" value = "Add"> 
         </form>
         <!-- Finish Add New Student Form-->
         <br>
         </br>
         <!-- Students Data Table -->
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                 <!-- Students Data Table Headers (Probably could get these from the database if necessary similar to the composer names) -->
                  <th>Name</th>
                  <th>Age</th>
                  <th>Bio</th>
                  <th>Class</th>
                  <th>Level</th>
                  <th>Actions</th>
               </tr>
               <?php
                  // If the user clicks on the "Add" button then this query will be executed. NOTE: There is no field for data so I just added 2021 as a default but this could be left blank              
                  if(isset($_POST["insertStudent"])) {
                     if($_POST["className"] = 'NULL'){
                        mysqli_query($connection, "INSERT into performer VALUES ('$_POST[name]', '$_POST[age]', '$_POST[bio]', NULL, '$_POST[levelID]')");
                     }
                     mysqli_query($connection, "INSERT into performer VALUES ('$_POST[name]', '$_POST[age]', '$_POST[bio]', '$_POST[className]', '$_POST[levelID]')");
                     printf("Error: %s\n", $connection -> error);
                     mysqli_query($connection, "INSERT into $_POST[instrument] VALUES ('$_POST[name]')");
                     printf("Error: %s\n", $connection -> error);
                  }
                  
                  // If the user clicks on the "search" button then this query will be executed and the page will be reloaded with the following query.
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM performer WHERE name LIKE '%$search%'";
                    
                    // Assuming there was some result then we need to build the table
                    if(mysqli_query($connection, $query))
                    {
                    $result = mysqli_query($connection, $query);
                      while($student=mysqli_fetch_assoc($result)) {
                      
                        echo "<tr>";
                      
                        echo "<td>".$student['name']."</td>";
                        
                        echo "<td>".$student['age']."</td>";
                        
                        echo "<td>".$student['bio']."</td>";
                        
                        echo "<td>".$student['classID']."</td>";
                        
                        echo "<td>".$student['levelID']."</td>";
                        
                        echo "<td><a href=DeleteStudent.php?id=".str_replace(" ","+",$student['name']).">Delete</a></td>";
                        
                        echo "</tr>";	
                              
                      }
                    }
                  }	else { // If there was not a search and the page was just loaded fresh then all results should be shown
                    $query = "SELECT * FROM performer";
                    $result = mysqli_query($connection, $query);
                    
                    while($student=mysqli_fetch_assoc($result)) {
                      echo "<tr>";
                      
                      echo "<td>".$student['name']."</td>";
                      
                      echo "<td>".$student['age']."</td>";
                      
                      echo "<td>".$student['bio']."</td>";
                      
                      echo "<td>".$student['classID']."</td>";
                      
                      echo "<td>".$student['levelID']."</td>";
                      
                      echo "<td><a href=DeleteStudent.php?id=".str_replace(" ","+",$student['name']).">Delete</a></td>";
                      
                      echo "</tr>";
                    }
                  }
                ?>
            </table>
         </div>
      </center>
   </body>
</html>