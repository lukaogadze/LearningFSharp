// let fingers = 10

// let add x y = x + y

// let five = add 2 3

let fingers: int = 10

// Compile error as the add binding has not yet been defined
// let seven = add 3 + 4
let add (x: int) (y: int) = x + y


let toes =
    let left = 5
    let right = 5
    left + right
    
let multiplyPlusTwo x y = x * y + 2

module Calculator =

    let pi = 3.14

    let add x y = x + y    