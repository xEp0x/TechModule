function solve(args) {
    let student = {};
    let parts = args.map(x => x.split(" -> "));
    for (let part of parts) {
        let key = part[0];
        let value = part[1];
        if (key === "age" || key === "grade") {
            value = Number(value);
        }
        student[key] = value;
    }

    console.log(JSON.stringify(student));
}

solve(["name -> Angel", "surname -> Georgiev", "age -> 20", "grade -> 6.00", "date -> 23/05/1995", "town -> Sofia"]);