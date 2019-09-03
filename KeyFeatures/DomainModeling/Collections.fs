namespace DomainModeling
                                //behind the scenes
module Collections =            
    let array1 = [|1 .. 10|]    //saved in a block o JSON memory cells
    let list1 = [ 1 .. 10 ]     //linked list
    let seq1 = seq { 1 .. 10 }  //interface
    let set1 = set { 1 .. 10 }  //create hash tables
    let map1 = Map.empty        //     same as before
                    .Add(1,"one").Add(2, "two").Add(3, "three")
                    .Add(4, "four").Add(5, "five").Add(6, "six")
                    .Add(7, "seven").Add(8,"eight").Add(9,"nine")
                    .Add(10,"ten")

module Arrays = //the size is immutable but the content isn't
    let array1 = [| 1; 2; 3 |]                  //
    let array2 = [| 1 .. 3 |]                   // range expression
    let array3 = [| for i in 1 .. 3 -> i|]      // for plus expression
    let array4 = Array.init 3 (fun id -> id + 1)// Call init to create an array with three elements and using the function to define the content
    let array5 = Array.create 3 0               // create an array with threee elements all set to zero

module Lists =      //all are linked list, the data is immutable
    let list1 = [ 1 ; 2 ; 3]
    let list2 = [ 1 .. 3]
    let list3 = [ for i in 1 .. 3 -> i ]
    let list4 = List.init 3 (fun id -> id + 1)
    let list5 : int list = []                   // empty list
    let list6 = 0 :: list1                      // cons operator - create a new list(list6) with a new head (0) and a existing list. Efficient operation

    //using pattern matching - separate head from the tail, use the head and call the same function with the tail
    let rec printTheList l =
        match l with
        | []        // if the list is empty
            ->  ()  // the stop
        | head :: tail          //otherwise, separate the head from the tail of 'l'
            ->  printfn "%i" head       //the print the head
                printTheList tail       // call the same function recursively for the tail

    list6 |> printTheList

module Sequences =                      // generic IEnumerable from .NET; Any object that implement IEnumerable can use this
    let seqArray1 = seq[| 1; 2; 3|]     // Array implements IEnumerable
    let seqArray2 = seq[| 1 .. 3 |]
    let seqList1 = seq [ 1; 2; 3 ]      // Lists implements IEnumerable
    let seqList2 = seq [ 1 .. 3 ]

    let seq1 = seq { 1 .. 3 }       // Doesnt specify, but calling the first time doesnt show the elements, but F# 'implements' it
    seq1 |> Seq.take 1 //nothing happens
    seq1               // now is shown

    let seq2 = seq { for i in 1 .. 3 -> i }
    let seq3 = Seq.init 3 (fun id -> id + 1)
    let seq4 = Seq.initInfinite (fun id -> id + 1) //sequence doesnt need to be finite

    seq4 |> Seq.take 1 // this can be executed indefinitely

module Sets =  
    let set1 = set [ 1; 2; 2; 3; ]  //prevent duplicate value; type must support equality and comparison
    let set2 = set1.Add 8           // create a new set with the number 8

    set1
    
    set1.IsProperSupersetOf set1    // if is a subset; in thsi case, a set is a subset of itself

module Maps =       //immutable dictionary
    let map1 = 
        Map
            .empty
            .Add(1, "one")
            .Add(2, "two")
            .Add(3, "three")
    printfn "%s" map1.[2]