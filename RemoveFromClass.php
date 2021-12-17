<?php

include "Connect.php"; 

$name = str_replace("+"," ",$_GET['performer']);


$del = mysqli_query($connection,"UPDATE performer SET classID = NULL WHERE name = '$name'"); // Delete query

if($del)
{
    mysqli_close($connection); // Close connection
    header('location:'. $_SERVER['HTTP_REFERER']); // Redirect back
    exit;	
}
else
{
    echo "Error deleting record"; // If issue
}
?>