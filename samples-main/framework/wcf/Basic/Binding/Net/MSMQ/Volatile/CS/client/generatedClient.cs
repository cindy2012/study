﻿//----------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//----------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.MSMQVolatileSample
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.Samples.MSMQVolatileSample", ConfigurationName="Microsoft.Samples.MSMQVolatileSample.IStockTicker")]
    public interface IStockTicker
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.MSMQVolatileSample/IStockTicker/StockTick")]
        void StockTick(string symbol, float price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockTickerChannel : Microsoft.Samples.MSMQVolatileSample.IStockTicker, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockTickerClient : System.ServiceModel.ClientBase<Microsoft.Samples.MSMQVolatileSample.IStockTicker>, Microsoft.Samples.MSMQVolatileSample.IStockTicker
    {
        
        public StockTickerClient()
        {
        }
        
        public StockTickerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public StockTickerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public StockTickerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public StockTickerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void StockTick(string symbol, float price)
        {
            base.Channel.StockTick(symbol, price);
        }
    }
}
