<?php

include "Connect.php"; 

$id = str_replace("+"," ",$_GET['id']);

$del = mysqli_query($connection,"delete from piece where pName = '$id'"); // Delete query

if($del)
{
    mysqli_close($connection); // Close connection
    header("location:ManagePieces.php"); // Redirect back
    exit;	
}
else
{
    echo "Error deleting record"; // If issue
}
?>