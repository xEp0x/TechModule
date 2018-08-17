function print(args) {
    for (let i = 0; i < args.length; i++) {
        if(args[i] != "Stop") {
            console.log(args[i]);
        } else {
            break;
        }
    }
}

print(["2", "3", "4", "Stop", "10"]);