<form>
    <div>Name:</div><input type="text" name="personName"/>
    <div>Age:</div><input type="number" name="age"/>
    <div>Town:</div>
    <select name="townId">
        <option value="1">Sofia</option>
        <option value="2">Varna</option>
        <option value="3">Plovdiv</option>
        <option value="4">Burgas</option>
    </select>
    <div><input type="submit"/></div>
</form>
<?php
    var_dump($_GET);
?>