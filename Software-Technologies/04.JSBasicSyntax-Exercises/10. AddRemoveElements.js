function solve(args) {
    let array = [];
    for (let i = 0; i < args.length; i++) {
        let parts = args[i].split(" ");
        let command = parts[0];
        let value = Number(parts[1]);
        switch (command) {
            case "add":
                array.push(value);
                break;
            case "remove":
                array.splice(value, 1);
                break;
        }
    }

    for (let element of array) {
        console.log(element);
    }
}

solve(["add 3", "add 5", "remove 2", "remove 0", "add 7"]);