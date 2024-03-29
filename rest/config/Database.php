<?php  
    class Database {
    // Params
    private $host = 'localhost';
    private $db_name = 'music';
    private $username = 'root';
    private $password = '';
    private $conn;

    //Arbitrary Change

    //DB Connect
    public function connect() {
        $this->conn = null;

        try {
            $this->conn = new PDO('mysql:host=' . $this->host . ';port=8080;dbname=' . $this->db_name,
            $this->username, $this->password);
            $this->conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        } catch(PDOException $e) {
            echo 'Connection Error: ' . $e->getMessage();
        }

    return $this->conn;    
    }
}