<?php

include "Connect.php"; 

$id = str_replace("+"," ",$_GET['id']);

$del = mysqli_query($connection,"delete from performer where name = '$id'"); // Delete query

if($del)
{
    mysqli_close($connection); // Close connection
    header("location:ManageStudents.php"); // Redirect back
    exit;	
}
else
{
    echo "Error deleting record"; // If issue
    printf("Error: %s\n", $connection -> error);
}
?>