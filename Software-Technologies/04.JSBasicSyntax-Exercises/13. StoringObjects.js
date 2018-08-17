function solve(args) {
    let students = [];
    for (let i = 0; i < args.length; i++) {
        let parts = args[i].split(" ");
        let name = parts[0];
        let age = parts[2];
        let grade = parts[4];

        let student = {name: name, age: age, grade: grade};
        students.push(student);
    }

    for (let student of students) {
        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade}`);
    }
}

solve(["Pesho -> 13 -> 6.00", "Ivan -> 12 -> 5.57", "Toni -> 13 -> 4.90"]);