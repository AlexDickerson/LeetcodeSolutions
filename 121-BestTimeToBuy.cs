public class Solution {
    public int MaxProfit(int[] prices) {
        var pricesPerDay = new List<(int, int)>(); //price, day
        for(int i = 0; i < prices.Length; i++){
            pricesPerDay.Add((prices[i], i));
        }
        pricesPerDay = pricesPerDay.OrderByDescending(p => p.Item1).ThenByDescending(p => p.Item2).ToList();
        int retVal = 0;
        for(int i = 0; i < prices.Length; i++){
            for(int j = 0; j < prices.Length; j++){
                if(pricesPerDay[i].Item2 > pricesPerDay[prices.Length - 1 - j].Item2){
                    var profit = pricesPerDay[i].Item1 - pricesPerDay[prices.Length - 1 - j].Item1;
                    if(retVal < profit) retVal = profit;
                    if(i != prices.Length - 1){
                        if(retVal >= pricesPerDay[i+1].Item1) return retVal;                        
                    }
                }
            }
        }
        
        return retVal;
    }
}