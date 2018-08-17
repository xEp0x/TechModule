function setValue(args) {
    let n = Number(args[0]);
    let array = [];
    for (let i = 0; i < n; i++) {
        array[i] = 0;
    }
    for (let i = 1; i < args.length; i++) {
        let elements = args[i].split(' ');
        let index = Number(elements[0]);
        let value = Number(elements[2]);
        array[index] = value;
    }
    for(let element of array) {
        console.log(element);
    }
}

setValue(["2", "0 - 5", "0 - 6", "0 - 7"]);