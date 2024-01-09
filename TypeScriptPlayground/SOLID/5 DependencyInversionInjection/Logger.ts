//* Low-level class
abstract class Logger{
   abstract log(message:string):void
}

//* Low level implementations of the Low-Level Class
class ErrorLogger extends Logger{
    log(message:string) {
        console.log(`Error: ${message}`)
    }
    
}
//* Higher order component /class that injects the Error Logger ie an implementation of the lower level abstact object
class AppLogger {
    private appLogger: Logger
    
    constructor(logger:Logger) {
       this.appLogger = logger
        
    }
    LogMessage(message:string) {
        this.appLogger.log(message)
    }
    
}
const errorLogger  = new ErrorLogger()
const appLogger = new AppLogger(errorLogger)
appLogger.LogMessage('Problem ohh')