<!DOCTYPE html>
    <html>
        <head>
            <title>Performer Landing Page</title>
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
            <table>
                <tr>
                    <th>Piece Name</th>
                    <th>Genre</th>
                    <th>Composed</th>
                    <th>Info</th>
                    <th>Link</th>
                    <th>Composer</th>
                    <th>Bio</th>
                    <th>Period</th>
                </tr>
            <?php
                for ($x = 0; $x <= 8; $x++) {
                    echo "<tr><td>" . "name" . $x . "</td>
                    <td>" . "genre" . $x . "</td>
                    <td>". "date" . $x . "</td>
                    <td>" . "information" . $x . "</td>
                    <td>" . "www.sheetmusic.com" . $x . "</td>
                    <td>" . "Name" . $x . "</td>
                    <td>" . "This is the " . $x . " bio I have written" . "</td>
                    <td>" . "10/12/190" . $x . "</td></tr>";
                }
            echo "</table>";
            ?>
        </table>
    </body>
</html>