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
         <!-- Populates with an image at the top and will take you back to the default view (not searched) if clicked -->
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManagePerformances.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
            <!-- Search Form -->
            <h2> Search Performances </h2>
            <form action ="ManagePerformances.php" method="GET">
               <input type="text" name="search" placeholder="What are you looking for?"/> <!-- name is used to determine the query block below -->
               <input type="submit" value="Search"/>
            </form>
         </div>
         <!-- Add New Piece Form -->
         <h2 class="header"> Add New Performance </h2>
         <form action ="ManagePerformances.php" method="POST">
            <label for="text">Performance Name:</label>
            <input type="text" name="perf_name" placeholder="Performance Name">
         <!-- Gets all composers from the database and then adds them to the drop down of selectable values -->
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
            <!-- Finish getting the composers -->

            <!-- Gets all composers from the database and then adds them to the drop down of selectable values -->
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
            <!-- Finish getting the composers -->
            <input type = "submit" name = "insertPerformance" value = "Add"> 
         </form>
         <!-- Finish Add New Piece Form-->
         <br>
         </br>
         <!-- Pieces Data Table -->
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                 <!-- Pieces Data Table Headers (Probably could get these from the database if necessary similar to the composer names) -->
                  <th>Performance Name</th>
                  <th>ProgramID</th>
                  <th>Piece</th>
                  <th>Actions</th>
               </tr>
               <?php
                  // If the user clicks on the "Add" button then this query will be executed. NOTE: There is no field for data so I just added 2021 as a default but this could be left blank              
                  if(isset($_POST["insertPerformance"])) {
                    mysqli_query($connection, "INSERT into performance VALUES ('$_POST[perf_name]', '$_POST[pID]', '$_POST[pName]')");
                    printf("Error 1: %s\n", $connection -> error);
                  }
                  
                  // If the user clicks on the "search" button then this query will be executed and the page will be reloaded with the following query.
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM performance WHERE perf_name LIKE '%$search%' or pID LIKE '%$search%' or piece_name LIKE '$search'";
                    
                    // Assuming there was some result then we need to build the table
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
                  }	else { // If there was not a search and the page was just loaded fresh then all results should be shown
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