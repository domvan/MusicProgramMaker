<?php
    class Performer {
        // DB stuff
        private $conn;
        private $table = 'performer';

        // Performer Properties
        public $name;
        public $age;
        public $bio;
        public $classID;
        public $levelID;

        //Constructor with DB
        public function __construct($db) {
            $this->conn = $db;
        }

        public function read() {
            $query = 
                'SELECT *
                FROM ' . $this->table . '
                ';

            $stmt = $this->conn->prepare($query);

            $stmt->execute();

            return $stmt;

        }

        //Test comment
    }