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
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManageStudents.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
            <h2> Search Students </h2>
            <form action ="ManageStudents.php" method="GET">
               <input type="text" name="search" placeholder="Search for students"/>
               <input type="submit" value="Search"/>
            </form>
         </div>
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
                  <?php 
                     $sql = mysqli_query($connection, "SELECT classID FROM class");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['classID'].'"> '.$row['classID'].' </option>';
                     }
                     ?>
               </select>
            </label>
            <label for="text">
               Level:
               <select name="levelID">
                  <?php 
                     $sql = mysqli_query($connection, "SELECT levelID FROM level");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['levelID'].'"> '.$row['levelID'].' </option>';
                     }
                     ?>
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
         <br>
         </br>
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                  <th>Name</th>
                  <th>Age</th>
                  <th>Bio</th>
                  <th>Class</th>
                  <th>Level</th>
                  <th>Actions</th>
               </tr>
               <?php          
                  if(isset($_POST["insertStudent"])) {
                     if($_POST["className"] = 'NULL'){
                        mysqli_query($connection, "INSERT into performer VALUES ('$_POST[name]', '$_POST[age]', '$_POST[bio]', NULL, '$_POST[levelID]')");
                     }
                     mysqli_query($connection, "INSERT into performer VALUES ('$_POST[name]', '$_POST[age]', '$_POST[bio]', '$_POST[className]', '$_POST[levelID]')");
                     printf("Error: %s\n", $connection -> error);
                     mysqli_query($connection, "INSERT into $_POST[instrument] VALUES ('$_POST[name]')");
                     printf("Error: %s\n", $connection -> error);
                  }
                  
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM performer WHERE name LIKE '%$search%'";
                    
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
                  }	else {
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