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