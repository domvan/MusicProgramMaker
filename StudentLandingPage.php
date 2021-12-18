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
   <a href="AdminLandingPage.php">&#8592 Logout</a>
      <center>
         <!-- Populates with an image at the top and will take you back to the default view (not searched) if clicked -->
         <div class ="taskbar">
            <!-- Search Form -->
            <h1> Search Pieces </h>
            <form action ="StudentLandingPage.php" method="GET">
               <input type="text" name="search" placeholder="What are you looking for?"/> <!-- name is used to determine the query block below -->
               <input type="submit" value="Search"/>
               <button onclick="StudentLandingPage.php">All</button>
            </form>
         </div>
         <!-- Add New Piece Form -->
         <h2 class="header"> My Pieces </h2>
         <!-- Finish Add New Piece Form-->
         <!-- Pieces Data Table -->
         <div class ="tableview">
            <table width="1100" border="1" cellpadding="1" cellspacing="1">
               <tr>
                 <!-- Pieces Data Table Headers (Probably could get these from the database if necessary similar to the composer names) -->
                  <th>Name</th>
                  <th>Genre</th>
                  <th>Composed</th>
                  <th>Info</th>
                  <th>Music Sheet Link</th>
                  <th>Composer</th>
                  <th>Bio</th>
                  <th>Period</th>
               </tr>
               <?php                  
                  // If the user clicks on the "search" button then this query will be executed and the page will be reloaded with the following query.
                  if(isset($_GET["search"])) {
                    $search = $_GET["search"];
                    $search = mysqli_real_escape_string($connection, $search);
                    
                    $query = "SELECT * FROM piece, composer WHERE (composer.cName = piece.c_name) AND (pName LIKE '%$search%' or genre LIKE '%$search%' or info LIKE '$search' or musicSheetLink LIKE '$search'
                    or c_name LIKE '%$search%' or date LIKE '%$search%' or  bio LIKE '%$search%' or period LIKE '%$search%')";
                    
                    // Assuming there was some result then we need to build the table
                    if(mysqli_query($connection, $query))
                    {
                    $result = mysqli_query($connection, $query);
                      while($piece=mysqli_fetch_assoc($result)) {
                      
                              echo "<tr>";
                      
                              echo "<td>".$piece['pName']."</td>";
                      
                              echo "<td>".$piece['genre']."</td>";

                              echo "<td>".$piece['date']."</td>";
                      
                              echo "<td>".$piece['info']."</td>";
                      
                              echo "<td>".$piece['musicSheetLink']."</td>";
                      
                              echo "<td>".$piece['c_name']."</td>";

                              echo "<td>".$piece['bio']."</td>";

                              echo "<td>".$piece['period']."</td>";
                      
                              echo "</tr>";	
                              
                      }
                    }
                  }	else { // If there was not a search and the page was just loaded fresh then all results should be shown
                    $query = "SELECT * FROM piece, composer WHERE (composer.cName = piece.c_name)";
                    $result = mysqli_query($connection, $query);
                    
                    while($piece=mysqli_fetch_assoc($result)) {
                     echo "<tr>";
                      
                     echo "<td>".$piece['pName']."</td>";
             
                     echo "<td>".$piece['genre']."</td>";

                     echo "<td>".$piece['date']."</td>";
             
                     echo "<td>".$piece['info']."</td>";
             
                     echo "<td>".$piece['musicSheetLink']."</td>";
             
                     echo "<td>".$piece['c_name']."</td>";

                     echo "<td>".$piece['bio']."</td>";

                     echo "<td>".$piece['period']."</td>";
             
                     echo "</tr>";	
                    }
                  }
                ?>
            </table>
         </div>
      </center>
   </body>
</html>