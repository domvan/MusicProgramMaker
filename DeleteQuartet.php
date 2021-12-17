<?php

include "Connect.php"; 

$id = str_replace("+"," ",$_GET['id']);

$del = mysqli_query($connection,"delete from quartet where gID = '$id'");
$del2 = mysqli_query($connection,"delete from team where gID = '$id'"); // Delete query
printf("Error: %s\n", $connection -> error);

if($del)
{
    mysqli_close($connection); // Close connection
    header("location:ManageQuartets.php"); // Redirect back
    exit;	
}
else
{
    echo "Error deleting record"; // If issue
    printf("Error: %s\n", $connection -> error);
}
?>