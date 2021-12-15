<?php

include "Connect.php"; 

$id = str_replace("+"," ",$_GET['id']);


$del = mysqli_query($connection,"delete from piece where pName = '$id'"); // delete query

if($del)
{
    mysqli_close($connection); // Close connection
    header("location:ManagePieces.php"); // redirects to all records page
    exit;	
}
else
{
    echo "Error deleting record"; // display error message if not delete
}
?>