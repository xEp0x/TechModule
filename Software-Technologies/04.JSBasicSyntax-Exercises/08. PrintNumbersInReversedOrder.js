function print(args) {
    for (let i = args.length - 1; i >= 0; i--) {
        console.log(args[i]);
    }
}

print(["10", "15", "20"]);