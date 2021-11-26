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
            <title>Manage Pieces</title>
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
<body>
    <h2 class="header"> Add New Piece </h2>
    <form class="form-inline">
        <label for="text">Name:</label>
            <input type="text" id="name" placeholder="Piece Name" name="name">
          <label for="text">Genre:</label>
            <input type="text" id="name" placeholder="Genre" name="name">
          <label for="text">Info:</label>
            <input type="text" id="name" placeholder="Info" name="name">
          <label for="text">Music Sheet Link:</label>
            <input type="text" id="name" placeholder="Link" name="name">
        <label for="teacher">Composer:
            <select name="teacher" id="teacher">
                <option value="Teacher">Bach</option>
                <option value="Mrs. 2">Mrs. 2</option>
                <option value="Mrs. 3">Mrs. 3</option>
                <option value="Mrs. 4">Mrs. 4</option>
            </select>
            </label>
        <button type="submit">Submit</button>
    </form>

</body>
            <table>
                <tr>
                    <th>Name</th>
                    <th>Genre</th>
                    <th>Info</th>
                    <th>Music Sheet Link</th>
                    <th>Composer</th>
                    <th> </th>
                </tr>
            <?php
                for ($x = 4; $x <= 10; $x++) {
                    echo "<tr><td>" . "Piece" . $x . "</td>
                    <td>". "Genre" . $x . "</td>
                    <td>". "This is the " . $x . " th information" . "</td>
                    <td>". "www.sheetmusic.com/" . $x . "</td>
                    <td>". "Composer" . $x . "</td>
                    <td> <input type = submit value = " . "Delete" . " class = submitbutton></td></tr>";
                }
            echo "</table>";
            ?>
        </table>
    </body>
</html>