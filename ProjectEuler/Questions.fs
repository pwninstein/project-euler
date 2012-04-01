module Questions

let question1 () = 
    Helpers.getMultiples [|3; 5;|] 999 |> Seq.sum