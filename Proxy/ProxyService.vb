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
Imports SmartContracts.Contracts.Proxy.ContractDefinition
Namespace SmartContracts.Contracts.Proxy


    Public Partial Class ProxyService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal proxyDeployment As ProxyDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of ProxyDeployment)().SendRequestAndWaitForReceiptAsync(proxyDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal proxyDeployment As ProxyDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of ProxyDeployment)().SendRequestAsync(proxyDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal proxyDeployment As ProxyDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of ProxyService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, proxyDeployment, cancellationTokenSource)
            Return New ProxyService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function DeployRequestAsync(ByVal deployFunction As DeployFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of DeployFunction)(deployFunction)
        
        End Function

        Public Function DeployRequestAndWaitForReceiptAsync(ByVal deployFunction As DeployFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of DeployFunction)(deployFunction, cancellationToken)
        
        End Function

        
        Public Function DeployRequestAsync(ByVal [code] As Byte()) As Task(Of String)
        
            Dim deployFunction = New DeployFunction()
                deployFunction.Code = [code]
            
            Return ContractHandler.SendRequestAsync(Of DeployFunction)(deployFunction)
        
        End Function

        
        Public Function DeployRequestAndWaitForReceiptAsync(ByVal [code] As Byte(), ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim deployFunction = New DeployFunction()
                deployFunction.Code = [code]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of DeployFunction)(deployFunction, cancellationToken)
        
        End Function
    
    End Class

End Namespace
