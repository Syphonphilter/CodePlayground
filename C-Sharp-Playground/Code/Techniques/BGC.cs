class BGCTask{
    public double tunnelConverter( int number){
        // define start of the tunnel
        double tunnelStart = 2.75;
        // define the end of the tunnel
        double tunnelEnd = 4.75;
        // define one mile to meters
        double _oneMileToMeter = 1600.00;
        
        double inTunnelConverter = -1;
         if(tunnelStart>= number || number<=tunnelEnd){
                inTunnelConverter = number*_oneMileToMeter;
         }
         return inTunnelConverter;
    }
    
}