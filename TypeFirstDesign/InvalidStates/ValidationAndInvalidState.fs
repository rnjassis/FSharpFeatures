namespace InvalidStates

module Validation = 
    type Account = Account
    type Identification =
        | DriverLicense of string
        | SocialSecurityNumber of string

    type twoIds =
        private //prevents to create two Identification, and assign to Ids and then to twoIds
        | Ids of Identification * Identification

    let makeTwoIds (id1: Identification) (id2: Identification) =
        match(id1, id2) with
            | (DriverLicense _), (DriverLicense _)
                -> None
            | (SocialSecurityNumber _), (SocialSecurityNumber _)
                -> None
            | _
                -> Some (Ids (id1, id2))
    let createAccount (ids: twoIds) =
        let Ids (id1, id2) = ids
        Account

module Testing =
    open Validation

    let validIds = makeTwoIds(DriverLicense "something") (SocialSecurityNumber "123")
    let validAccount = createAccount validIds.Value

    let invalidIds = makeTwoIds(DriverLicense "something") (DriverLicense "something")
    let invalidAccount = createAccount invalidIds.Value // return None, so it throws a runtime error