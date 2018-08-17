function solve(args) {
    let obj = {};
    for (let i = 0; i < args.length - 1; i++) {
        let parts = args[i].split(" ");
        let key = parts[0];
        let value = parts[1];

        if (obj[key]) {
            obj[key].push(value);
        } else {
            obj[key] = [value];
        }
    }

    let searchedKey = args[args.length - 1];
    if (obj[searchedKey]) {
        console.log(obj[searchedKey].join("\n"))
    } else {
        console.log("None");
    }
}

solve(["key value", "key eulav", "test tset", "key"]);