module Helpers

let getMultiples ( numbers : int seq ) (max : int) =  seq {
    for value in 1 .. max do 
        if numbers |> Seq.exists (fun i -> value % i = 0) then yield value
}