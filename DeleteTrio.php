<?php

include "Connect.php"; 

$id = str_replace("+"," ",$_GET['id']);

$del = mysqli_query($connection,"delete from trio where gID = '$id'"); // Delete query
$del2 = mysqli_query($connection,"delete from team where gID = '$id'"); // Delete query

if($del)
{
    mysqli_close($connection); // Close connection
    header("location:ManageTrios.php"); // Redirect back
    exit;	
}
else
{
    echo "Error deleting record"; // If issue
    printf("Error: %s\n", $connection -> error);
}
?>