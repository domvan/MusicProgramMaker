<!-- Creates a connection to the database -->
<?php
   include "Connect.php";
   ?>
<!-- -------------------------------------- -->

<!DOCTYPE HTML>
<html>
  <!-- Header for Tab -->
   <head>
      <title>Manage Pieces</title>
      <meta http-equiv="Content-Type" content="text/html; charset=iso=8859-1">
      <link rel="stylesheet" type="text/css" href="style.css">
   </head>
     <!-- Start of Body -->
   <body>
      <center>
         <!-- Populates with an image at the top and will take you back to the default view (not searched) if clicked -->
         <div class ="taskbar">
            <a href="/MusicProgramMaker/ManagePieces.php">
            <img src="https://pngimg.com/uploads/music_notes/music_notes_PNG38.png" width="600" height="200"> 
            </a>
            <!-- Search Form -->
            <h2> Search Pieces </h2>
            <form action ="ManagePieces.php" method="GET">
               <input type="text" name="search" placeholder="What are you looking for?"/> <!-- name is used to determine the query block below -->
               <input type="submit" value="Search"/>
            </form>
         </div>
         <!-- Add New Piece Form -->
         <h2 class="header"> Add New Piece </h2>
         <form action ="ManagePieces.php" method="POST">
            <label for="text">Name:</label>
            <input type="text" name="name" placeholder="Piece Name">
            <label for="text">Genre:</label>
            <input type="text" name="genre" placeholder="Genre">
            <label for="text">Info:</label>
            <input type="text" name="info" placeholder="Info">
            <label for="text">Music Sheet Link:</label>
            <input type="text" name="link" placeholder="Link">
            <label for="text">
               Composer:
               <select name="cname">
                  <!-- Gets all composers from the database and then adds them to the drop down of selectable values -->
                  <?php 
                     $sql = mysqli_query($connection, "SELECT cName FROM composer");
                     while ($row = $sql->fetch_assoc()){
                       echo '<option value=" '.$row['cName'].' "> '.$row['cName'].' </option>';
                     }
                     ?>
                  <!-- Finish getting the composers -->
               </select>
            </label>
            <input type = "submit" name = "insertPiece" value = "Add"> 
         </form>
         <!-- Finish Add New Piece Form-->
         <br>
         </br>
         <!-- Pieces Data Table -->
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                 <!-- Pieces Data Table Headers (Probably could get these from the database if necessary similar to the composer names) -->
                  <th>Name</th>
                  <th>Genre</th>
                  <th>Info</th>
                  <th>Music Sheet Link</th>
                  <th>Composer</th>
                  <th>Actions</th>
               </tr>
               <?php
                  // If the user clicks on the "Add" button then this query will be executed. NOTE: There is no field for data so I just added 2021 as a default but this could be left blank              
                  if(isset($_POST["insertPiece"])) {
                     mysqli_query($connection, "INSERT into piece VALUES ('$_POST[name]', '$_POST[info]', '2021', '$_POST[genre]', '$_POST[link]', '$_POST[cname]')");
                  }
                  
                  // If the user clicks on the "search" button then this query will be executed and the page will be reloaded with the following query.
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM piece WHERE pName LIKE '%$search%' or genre LIKE '%$search%' or info LIKE '$search' or musicSheetLink LIKE '$search'
                    or c_name LIKE '%$search%'";
                    
                    // Assuming there was some result then we need to build the table
                    if(mysqli_query($connection, $query))
                    {
                    $result = mysqli_query($connection, $query);
                      while($piece=mysqli_fetch_assoc($result)) {
                      
                              echo "<tr>";
                      
                              echo "<td>".$piece['pName']."</td>";
                      
                              echo "<td>".$piece['genre']."</td>";
                      
                              echo "<td>".$piece['info']."</td>";
                      
                              echo "<td>".$piece['musicSheetLink']."</td>";
                      
                              echo "<td>".$piece['c_name']."</td>";
                      
                              echo "<td><a href=DeletePiece.php?id=".str_replace(" ","+",$piece['pName']).">Delete</a></td>";
                      
                              echo "</tr>";	
                              
                      }
                    }
                  }	else { // If there was not a search and the page was just loaded fresh then all results should be shown
                    $query = "SELECT * FROM piece";
                    $result = mysqli_query($connection, $query);
                    
                    while($piece=mysqli_fetch_assoc($result)) {
                      echo "<tr>";
                      
                      echo "<td>".$piece['pName']."</td>";
                      
                      echo "<td>".$piece['genre']."</td>";
                      
                      echo "<td>".$piece['info']."</td>";
                      
                      echo "<td>".$piece['musicSheetLink']."</td>";
                      
                      echo "<td>".$piece['c_name']."</td>";
                      
                      echo "<td><a href=DeletePiece.php?id=".str_replace(" ","+",$piece['pName']).">Delete</a></td>";
                      
                      echo "</tr>";
                    }
                  }
                ?>
            </table>
         </div>
      </center>
   </body>
</html>