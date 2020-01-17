// Find the sum of all even fibonacci numbers < 4,000,000


let rec fib n =  //Fibonacci # generator
    match n with
        | 0 -> 0
        | 1 -> 1
        | _ -> (fib (n - 1) + fib (n-2))

let rec fibsum (a,b) = //Sum of fibonacci numbers up to the bth fib number
    match a with
        | a when a >= b -> fib a
        | a -> fib (a) + fibsum (a + 1,b)

let b = fibsum (1,10)
printfn "%i" b
(*
let rec SumOfEvens a = 
    match a with
        | a when fib (a) > 4000000 -> a
        | a when a % 2 = 0 -> SumOfEvens (a + fib (a + 1))
        | a -> SumOfEvens (fib (a + 1))
        *)

System.Console.ReadKey() |> ignore