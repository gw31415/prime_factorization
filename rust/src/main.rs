fn main() {
    for n in 1..100000{
        let mut arr: std::vec::Vec<u32> = vec![];
        let mut temp = n;
        for i in 2..((n as f32).sqrt() as u32 + 1) {
            while temp % i == 0{
                arr.push(i);
                temp /= i;
            }
        }
        if temp != 1{
            arr.push(temp);
        }
        if arr.is_empty() {
            arr.push(n);
        }
    }
}
