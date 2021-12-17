<?php

include "Connect.php"; 

$id = str_replace("+"," ",$_GET['id']);

$del1 = mysqli_query($connection,"UPDATE performer SET classID = NULL WHERE classID = '$id'");
$del2 = mysqli_query($connection,"delete from class where classID = '$id'"); // Delete query

if($del1)
{
    mysqli_close($connection); // Close connection
    header("location:ManageClasses.php"); // Redirect back
    exit;	
}
else
{
    echo "Error deleting record"; // If issue
}

if($del2)
{
    mysqli_close($connection); // Close connection
    header("location:ManageClasses.php"); // Redirect back
    exit;	
}
else
{
    echo "Error deleting record"; // If issue
}
?>