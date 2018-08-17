<form>
    Celsius: <input type="text" name="cel"/>
    <input type="submit" value="Convert">
    <?php
    $msgAfterCelsius = "";
    if (isset($_GET['cel'])) {
        $cel = floatval($_GET['cel']);
        $fah = celsiusToFahrenhait($cel);
        $msgAfterCelsius = "$cel &deg;C = $fah &deg;F";
    }
    echo $msgAfterCelsius
    ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah"/>
    <input type="submit" value="Convert">
    <?php
    $msgAfterFahrenfait = "";
    if (isset($_GET['fah'])) {
        $fah = floatval($_GET['fah']);
        $cel = fahrenhaitToCelsius($fah);
        $msgAfterFahrenfait = "$fah &deg;F = $cel &deg;C";
    }
    echo $msgAfterFahrenfait;
    ?>
</form>

<?php
function celsiusToFahrenhait(float $celsius): float
{
    return $celsius * 1.8 + 32;
}

function fahrenhaitToCelsius(float $fahrenhait): float
{
    return ($fahrenhait - 32) / 1.8;
}
?>
