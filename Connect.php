<?php
$connection = mysqli_connect("localhost", "root", "", "music");

if(!$connection) {
  echo "Unable to Connect to Database";
	die('Unable to connect'. mysqli_error($connection));
}
?>