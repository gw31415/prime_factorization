#include <vector>
#include <cmath>
using namespace std;
int main(){
  for (int n = 0; n < 100000; n++) {
    vector<int> arr;
    int temp = n;
    for (int i = 2 ; i < floor(sqrt((double) n)) + 1; i++)
      while (!(temp % i)) {
        arr.push_back(i);
        temp /= i;
      }
    if (temp != 1) arr.push_back(temp);
    if (arr.empty()) arr.push_back(n);
  }
}
