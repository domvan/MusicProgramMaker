<!DOCTYPE html>
  <html>
    <head>
      <meta name="viewport" content="width=device-width, initial-scale=1">
        <style>

h2.header {
  text-align: center;
}
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box;}

.form-inline {  
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  margin: auto;
  text-align: center;
  width: 650px;
}

.form-inline label {
  margin: 5px 10px 5px 0;
}

.form-inline input {
  vertical-align: middle;
  margin: 5px 10px 5px 0;
  padding: 10px;
  background-color: #fff;
  border: 1px solid #ddd;
}

.form-inline button {
  padding: 10px 20px;
  background-color: dodgerblue;
  border: 1px solid #ddd;
  color: white;
  cursor: pointer;
}

.form-inline button:hover {
  background-color: royalblue;
}

@media (max-width: 800px) {
  .form-inline input {
    margin: 10px 0;
  }
  
  .form-inline {
    flex-direction: column;
    align-items: center;
  }
}

</style>
  <title>Manage Groups</title>
    <style>
        table {
            border-collapse: collapse;
            width: 75%;
            color: #000000;
            font-family: arial;
            font-size: auto;
            text-align: center;
            margin-left: auto;
            margin-right: auto;
            }
        th {
            background-color: #000000;
            color: white;
        }
        tr:nth-child(even) {background-color: #D3D3D3}
    </style>
</head>
<body>
  <div>
    <h2 class="header"> Manage Solo Performers </h2>
    <form class="form-inline">
        <label for="username">Username:</label>
          <input type="text" id="username" placeholder="Unique Username" name="username">
        <label for="username">Name:</label>
          <input type="text" id="username" placeholder="Full Name" name="username">
        <label for="bio">Bio:</label>
          <input type="text" id="bio" placeholder="I am a..." name="bio">
      <label for="level">Level:
        <select name="level" id="level">
          <option value="Level">1</option>
          <option value="2">2</option>
          <option value="3">3</option>
          <option value="4">4</option>
        </select>
      </label>
      <button type="submit">Submit</button>
    </form>
            <table>
                <tr>
                    <th>Username/th>
                    <th>Name</th>
                    <th>Bio</th>
                    <th> </th>
                </tr>
            <?php
                for ($x = 4; $x <= 8; $x++) {
                    echo "<tr><td>" . "User" . $x . "</td>
                    <td>" . "John Bob the " . $x . "th" . "</td>
                    <td>". "I have performed in at least " . $x . " shows" . "</td>
                    <td> <input type = submit value = " . "Delete" . " class = submitbutton></td></tr>";
                }
            echo "</table>";
            ?>
        </table>
              </div>
              <div>
    <h2 class="header"> Manage Trios </h2>
    <form class="form-inline">
    <label for="teacher">Violinist:
            <select name="teacher" id="teacher">
                <option value="Teacher">Mary</option>
                <option value="Mrs. 2">Mrs. 2</option>
                <option value="Mrs. 3">Mrs. 3</option>
                <option value="Mrs. 4">Mrs. 4</option>
            </select>
            </label>
        <label for="teacher">Cellist:
            <select name="teacher" id="teacher">
                <option value="Teacher">Tim</option>
                <option value="Mrs. 2">Mrs. 2</option>
                <option value="Mrs. 3">Mrs. 3</option>
                <option value="Mrs. 4">Mrs. 4</option>
            </select>
            </label>
            <label for="teacher">Pianist:
            <select name="teacher" id="teacher">
                <option value="Teacher">Bob</option>
                <option value="Mrs. 2">Mrs. 2</option>
                <option value="Mrs. 3">Mrs. 3</option>
                <option value="Mrs. 4">Mrs. 4</option>
            </select>
            </label>
            <label for="bio">Bio:</label>
          <input type="text" id="bio" placeholder="I am a..." name="bio">
          <label for="bio">Age:</label>
          <input type="text" id="bio" placeholder="Age" name="bio">
          <button type="submit">Submit</button>
    </form>
            <table>
                <tr>
                    <th>Violinist</th>
                    <th>Cellist</th>
                    <th>Pianist</th>
                    <th> </th>
                </tr>
            <?php
                for ($x = 0; $x <= 8; $x++) {
                    echo "<tr><td>" . "Violinist" . $x . "</td>
                    <td>" . "Cellist" . $x . "</td>
                    <td>". "Pianist" . $x . "</td>
                    <td> <input type = submit value = " . "Delete" . " class = submitbutton></td></tr>";
                }
            echo "</table>";
            ?>
        </table>
              </div>
              <div>
    <h2 class="header"> Manage Quartets </h2>
    <form class="form-inline">
        <label for="text">Name:</label>
            <input type="text" id="name" placeholder="Class Name" name="name">
        <label for="teacher">Teacher:
            <select name="teacher" id="teacher">
                <option value="Teacher">Mrs. 1</option>
                <option value="Mrs. 2">Mrs. 2</option>
                <option value="Mrs. 3">Mrs. 3</option>
                <option value="Mrs. 4">Mrs. 4</option>
            </select>
            </label>
    <label for="date">Time:</label>
        <input type="time" id="date" name="Date"
        min="09:00" max="18:00" required>
        <button type="submit">Submit</button>
    </form>
            <table>
                <tr>
                    <th>Name</th>
                    <th>Teacher</th>
                    <th>Time</th>
                    <th> </th>
                </tr>
            <?php
                for ($x = 0; $x <= 8; $x++) {
                    echo "<tr><td>" . "Class " . $x . "</td>
                    <td>" . "Mrs. " . $x . "</td>
                    <td>". "8:5" . $x . " AM" . "</td>
                    <td> <input type = submit value = " . "Delete" . " class = submitbutton></td></tr>";
                }
            echo "</table>";
            ?>
        </table>
              </div>
</body>
</html>