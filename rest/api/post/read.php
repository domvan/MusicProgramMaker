<?php
    // Headers
    header('Access-Controll-Allow-Origin: *');
    header('Content-Type: application/json');

    include_once '../../config/Database.php';
    include_once '../../models/Performer.php';

    // Instantiate DB and Connect
    $database = new Database();
    $db = $database->connect();

    // Instantiate Performer
    $performer = new Performer($db);

    $result = $performer->read();

    $num = $result->rowCount();

    if($num > 0) {
        $performers_arr = array();
        $performers_arr['data'] = array();

        while($row = $result->fetch(PDO::FETCH_ASSOC)) {
            extract($row);

            $performer_item = array(
                'name' => $name,
                'age' => $age,
                'bio' => $bio,
                'classID' => $classID,
                'levelID' => $levelID
            );

            array_push($performers_arr['data'], $performer_item);

        }
        echo json_encode($performers_arr);
    } else {
        echo json_encode(
            array('message' => 'No performers found')
        );
    }

