//* Target interface for the modern RESTful service
interface RestfulService {
  sendRequest(): void;
}

//* Adaptee class representing the legacy SOAP service
class LegacySoapService {
  makeSoapRequest(): void {
    console.log("Making SOAP request");
  }
}

//* Adapter class to adapt LegacySoapService to RestfulService interface
class SoapToRestAdapter implements RestfulService {
  private legacySoapService: LegacySoapService;

  constructor(legacySoapService: LegacySoapService) {
    this.legacySoapService = legacySoapService;
  }

  sendRequest(): void {
    console.log("Adapter is converting and sending RESTful request");
    this.legacySoapService.makeSoapRequest();
    // convert soap to REST
  }
}

//* Client code using RestfulService interface
const callRestfulServicefromSoap = (service: SoapToRestAdapter) => {
  service.sendRequest();
};

//* Example usage
const legacySoapService = new LegacySoapService();
const soapToRestAdapter = new SoapToRestAdapter(legacySoapService);

callRestfulServicefromSoap(soapToRestAdapter);
