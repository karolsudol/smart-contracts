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
Namespace SmartContracts.Contracts.D1.ContractDefinition

    
    
    Public Partial Class D1Deployment
     Inherits D1DeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class D1DeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "6080604052600080546001600160a01b0319163317905534801561002257600080fd5b50610151806100326000396000f3fe608060405234801561001057600080fd5b50600436106100365760003560e01c8063592bd7051461003b5780638da5cb5b14610050575b600080fd5b61004e6100493660046100eb565b61007f565b005b600054610063906001600160a01b031681565b6040516001600160a01b03909116815260200160405180910390f35b6000546001600160a01b031633146100c95760405162461bcd60e51b81526020600482015260096024820152683737ba1037bbb732b960b91b604482015260640160405180910390fd5b600080546001600160a01b0319166001600160a01b0392909216919091179055565b6000602082840312156100fd57600080fd5b81356001600160a01b038116811461011457600080fd5b939250505056fea26469706673582212208b186340ebe8feb40a3d6d1c109ce766f3adf08cc215068c9875e2e0cbc9d8e564736f6c634300080d0033"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class OwnerFunction
        Inherits OwnerFunctionBase
    End Class

        <[Function]("owner", "address")>
    Public Class OwnerFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class SetownerFunction
        Inherits SetownerFunctionBase
    End Class

        <[Function]("setowner")>
    Public Class SetownerFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_owner", 1)>
        Public Overridable Property [Owner] As String
    
    End Class
    
    
    Public Partial Class OwnerOutputDTO
        Inherits OwnerOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class OwnerOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    

End Namespace
