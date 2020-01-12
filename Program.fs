// FizzBuzz challenge
// Print a list from 1 to 100 where every number divisible by 3 and 5 is replaced by 'Fizz' and 'Buzz' respectively, and if a multiple of of both then prints 'FizzBuzz'

let list = [1 .. 100] // small change

let FizzBuzz = function
    | a when a % 3 = 0 & a % 5 = 0 -> printfn "FizzBuzz" //Some way to inject FizzBuzz at these points
    | a when a % 3 = 0 -> printfn "Fizz" //Some way to inject Fizz 
    | a when a % 5 = 0 -> printfn "Buzz" //Some way to inject Buzz
    | a -> printfn "%i" a //Some way to 


List.map (fun a -> FizzBuzz a) list

System.Console.ReadKey () |> ignore
