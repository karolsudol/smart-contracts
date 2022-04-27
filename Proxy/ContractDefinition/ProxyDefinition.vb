Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts
Imports System.Threading
Namespace SmartContracts.Contracts.Proxy.ContractDefinition

    
    
    Public Partial Class ProxyDeployment
     Inherits ProxyDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class ProxyDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "608060405234801561001057600080fd5b506101f5806100206000396000f3fe60806040526004361061001d5760003560e01c806277436014610022575b600080fd5b61003561003036600461010e565b610051565b6040516001600160a01b03909116815260200160405180910390f35b600081516020830134f090506001600160a01b0381166100b75760405162461bcd60e51b815260206004820152601b60248201527f6465706c6f79206661696c6564202d2061647265737320697320300000000000604482015260640160405180910390fd5b6040516001600160a01b03821681527f55ea6c6b31543d8e2ec6a72f71a79c0f4b72ed0d4757172b043d8f4f4cd848489060200160405180910390a1919050565b634e487b7160e01b600052604160045260246000fd5b60006020828403121561012057600080fd5b813567ffffffffffffffff8082111561013857600080fd5b818401915084601f83011261014c57600080fd5b81358181111561015e5761015e6100f8565b604051601f8201601f19908116603f01168101908382118183101715610186576101866100f8565b8160405282815287602084870101111561019f57600080fd5b82602086016020830137600092810160200192909252509594505050505056fea264697066735822122024021467bc242a4e2ed783a5ca71c2c44c1c7481a980a161210de50c5605226764736f6c634300080d0033"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class DeployFunction
        Inherits DeployFunctionBase
    End Class

        <[Function]("deploy", "address")>
    Public Class DeployFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("bytes", "_code", 1)>
        Public Overridable Property [Code] As Byte()
    
    End Class
    
    
    Public Partial Class DeployEventDTO
        Inherits DeployEventDTOBase
    End Class

    <[Event]("Deploy")>
    Public Class DeployEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "", 1, false)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    

End Namespace
