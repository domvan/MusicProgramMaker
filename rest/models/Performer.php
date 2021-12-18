<?php
    class Performer {
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
        public function create() {
            // Create Query
            $query = 'INSERT INTO ' .
            $this->table . '
            SET
            name = :name,
            age = :age,
            bio = :bio,
            classID = :classID,
            levelID = :levelID';

        // Prepare Statement
        $stmt = $this->conn->prepare($query);

        // Clean data
        $this->name = htmlspecialchars(strip_tags($this->name));
        $this->age = htmlspecialchars(strip_tags($this->age));
        $this->bio = htmlspecialchars(strip_tags($this->bio));
        $this->classID = htmlspecialchars(strip_tags($this->classID));
        $this->levelID = htmlspecialchars(strip_tags($this->levelID));

        // Bind data
        $stmt-> bindParam(':name', $this->name);
        $stmt-> bindParam(':age', $this->age);
        $stmt-> bindParam(':bio', $this->bio);
        $stmt-> bindParam(':classID', $this->classID);
        $stmt-> bindParam(':levelID', $this->levelID);


        // Execute query
        if($stmt->execute()) {
            return true;
        }
        // Print error if something goes wrong
        printf("Error: $s.\n", $stmt->error);

        return false;
        }
    }