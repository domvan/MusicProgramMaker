<!-- Creates a connection to the database -->
<?php
   include "Connect.php";
   ?>
<!-- -------------------------------------- -->

<!DOCTYPE HTML>
<html>
  <!-- Header for Tab -->
   <head>
      <title>Manage Performances</title>
      <meta http-equiv="Content-Type" content="text/html; charset=iso=8859-1">
      <link rel="stylesheet" type="text/css" href="style.css">
   </head>
     <!-- Start of Body -->
   <body>
   <a href="AdminLandingPage.php">&#8592 Back</a>
      <center>
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManagePerformances.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
            <h2> Search Performances </h2>
            <form action ="ManagePerformances.php" method="GET">
               <input type="text" name="search" placeholder="What are you looking for?"/>
               <input type="submit" value="Search"/>
            </form>
         </div>
         <h2 class="header"> Add New Performance </h2>
         <form action ="ManagePerformances.php" method="POST">
            <label for="text">Performance Name:</label>
            <input type="text" name="perf_name" placeholder="Performance Name">
            <label for="text">
               Program ID:
               <select name="pID">
                  <?php 
                     $sql = mysqli_query($connection, "SELECT pID FROM program");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value="'.$row['pID'].'"> '.$row['pID'].' </option>';
                     }
                     ?>
               </select>
            </label>
            <label for="text">
               Pieces:
               <select name="pName">
                  <?php 
                     $sql2 = mysqli_query($connection, "SELECT pName FROM piece");
                     while ($row2 = $sql2->fetch_assoc()){
                       echo '<option value="'.$row2['pName'].'"> '.$row2['pName'].' </option>';
                     }
                     ?>
               </select>
            </label>
            <input type = "submit" name = "insertPerformance" value = "Add"> 
         </form>
         <br>
         </br>
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                  <th>Performance Name</th>
                  <th>ProgramID</th>
                  <th>Piece</th>
                  <th>Actions</th>
               </tr>
               <?php            
                  if(isset($_POST["insertPerformance"])) {
                    mysqli_query($connection, "INSERT into performance VALUES ('$_POST[perf_name]', '$_POST[pID]', '$_POST[pName]')");
                    printf("Error 1: %s\n", $connection -> error);
                  }
                  
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM performance WHERE perf_name LIKE '%$search%' or pID LIKE '%$search%' or piece_name LIKE '$search'";
                    
                    if(mysqli_query($connection, $query))
                    {
                    $result = mysqli_query($connection, $query);
                      while($performance=mysqli_fetch_assoc($result)) {
                      
                              echo "<tr>";
                      
                              echo "<td>".$performance['perf_name']."</td>";
                      
                              echo "<td>".$performance['pID']."</td>";
                      
                              echo "<td>".$performance['piece_name']."</td>";
                      
                              echo "<td><a href=DeletePerformance.php?id=".str_replace(" ","+",$performance['perf_name']).">Delete</a></td>";
                      
                              echo "</tr>";	
                              
                      }
                    }
                  }	else {
                    $query = "SELECT * FROM performance";
                    $result = mysqli_query($connection, $query);
                    
                    while($performance=mysqli_fetch_assoc($result)) {
                      echo "<tr>";
                      
                     echo "<td>".$performance['perf_name']."</td>";
                      
                      echo "<td>".$performance['pID']."</td>";
                      
                      echo "<td>".$performance['piece_name']."</td>";
                      
                      echo "<td><a href=DeletePerformance.php?id=".str_replace(" ","+",$performance['perf_name']).">Delete</a></td>";
                      
                      echo "</tr>";
                    }
                  }
                ?>
            </table>
         </div>
      </center>
   </body>
</html>