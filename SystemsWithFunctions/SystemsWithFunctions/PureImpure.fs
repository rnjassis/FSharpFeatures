namespace SystemsWithFunctions

module PureAndImpureFunctions =
    type Application = Application
    type Ids = Ids
    type Deposit = Deposit
    type Account = Account

    let validateApplication (application: Application) =
        true
    let validateIds (ids: Ids) =
        true
    let validateDeposit (deposit: Deposit) = 
        true

    let openAccount
        validateApplication
        validateIds
        validateDeposit
        (application: Application)
        (ids: Ids)
        (deposit: Deposit) =
            
            if not (validateApplication application)
                then None
            elif not (validateIds ids)
                then None
            elif not (validateDeposit deposit)
                then None
            else Some Account