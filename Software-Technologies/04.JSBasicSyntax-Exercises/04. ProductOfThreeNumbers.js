function product(nums) {
    let num1 = Number(nums[0]);
    let num2 = Number(nums[1]);
    let num3 = Number(nums[2]);

    let product = num1 * num2 * num3;
    if (product < 0) {
        console.log("Negative")
    } else {
        console.log("Positive")
    }
}

product(["2", "3", "1"]);