<?php
  // Headers
  header('Access-Control-Allow-Origin: *');
  header('Content-Type: application/json');
  header('Access-Control-Allow-Methods: POST');
  header('Access-Control-Allow-Headers: Access-Control-Allow-Headers, Content-Type, Access-Control-Allow-Methods, Authorization,X-Requested-With');

  include_once '../../config/Database.php';
  include_once '../../models/Performer.php';
  // Instantiate DB & connect
  $database = new Database();
  $db = $database->connect();

  // Instantiate performer post object
  $performer = new Performer($db);

  // Get raw posted data
  $data = json_decode(file_get_contents("php://input"));

  $performer->name = $data->name;
  $performer->age = $data->age;
  $performer->bio= $data->bio;
  $performer->classID = $data->classID;
  $performer->levelID = $data->levelID;

  // Create Performer
  if($performer->create()) {
    echo json_encode(
      array('message' => 'Performer Created')
    );
  } else {
    echo json_encode(
      array('message' => 'Performer Not Created')
    );
  }