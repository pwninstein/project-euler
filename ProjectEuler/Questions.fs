module Questions

let question1 () = 
    Helpers.getMultiples [|3; 5;|] 999 |> Seq.sum

let question2 () =
    Helpers.fibonacci 3999999 |> Seq.filter( fun i -> i % 2 = 0 ) |> Seq.sum

let question3 () =
    Helpers.getPrimeFactors 600851475143L |> System.Linq.Enumerable.Last