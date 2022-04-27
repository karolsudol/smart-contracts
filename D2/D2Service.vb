Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts.ContractHandlers
Imports Nethereum.Contracts
Imports System.Threading
Imports SmartContracts.Contracts.D2.ContractDefinition
Namespace SmartContracts.Contracts.D2


    Public Partial Class D2Service
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal d2Deployment As D2Deployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of D2Deployment)().SendRequestAndWaitForReceiptAsync(d2Deployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal d2Deployment As D2Deployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of D2Deployment)().SendRequestAsync(d2Deployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal d2Deployment As D2Deployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of D2Service)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, d2Deployment, cancellationTokenSource)
            Return New D2Service(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    

    
    End Class

End Namespace
