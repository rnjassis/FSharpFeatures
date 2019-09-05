namespace TypeFirstDesign

module CheckAccount = 
    type CheckingAccount = 
        |   CheckingAccount //discriminated union
    type Application = Application
    type Identification = Identification
    type Deposit = decimal

    let openCheckingAccount 
        (application: Application)
        (id: Identification * Identification) //tuple
        (deposit: Deposit) =
            if deposit >= 500M
                then Some CheckingAccount
                else None
