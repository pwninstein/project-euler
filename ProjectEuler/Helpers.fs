module Helpers

let getMultiples ( numbers : int seq ) (max : int) =  seq {
    for value in 1 .. max do 
        if numbers |> Seq.exists (fun i -> value % i = 0) then yield value
}

let fibonacci ( max : int ) = 
    let previous = ref 1
    let number = ref 1
    seq {
        while !number <= max do
            yield !number     
            let temp = !number + !previous
            previous := !number
            number := temp       
    }

let isPrime ( number : int64 ) =
    let max = System.Math.Sqrt(float number)
    let x = ref 2L
    let value = ref true
    while !value && !x <= (int64 max) do
        if number % !x = 0L then value := false
        x := !x + 1L
    !value

let getFactors ( number : int64 ) = seq {
    for x in 1L .. number do
        if number % x = 0L then yield x
}

let getPrimeFactors ( number : int64 ) = seq {
    let max = System.Math.Sqrt(float number)
    for x in 2L .. (int64 max) do 
        if number % x = 0L && isPrime x then yield x
}