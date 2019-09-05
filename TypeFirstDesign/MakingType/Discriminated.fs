namespace MakingType

module DiscriminatedUnions = 
    type FirstName = FirstName of string    //all these types continue as string,
    type LastName = LastName of string      //but discriminated avoiding confusion between them
    type HomeNumber = HomeNumber of string                                      
    

    type PhoneBookEntry =
        {
            FirstName : FirstName
            LastName : LastName
            HomeNumber : HomeNumber
        }

    let createEntry firstName lastName homeNumber = 
        {
            FirstName = firstName
            LastName = lastName
            HomeNumber = homeNumber
        }

    let firstName = FirstName "Bob"             //now the strings are explicitly discriminated
    let lastName = LastName "James"
    let homeNumber = HomeNumber "123-456-789"

    let entry = createEntry firstName lastName homeNumber // if passed a pured string or mix the discriminated types, 
                                                          // F# will show a compile error
