#include <iostream>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

struct Lecture {
    int pay, day;
};

// 정렬 기준: 날짜 기준으로 내림차순 (큰 날짜부터)
bool cmp(Lecture a, Lecture b) {
    return a.day > b.day;
}

int main() {
    int n;
    cin >> n;
    
    vector<Lecture> lectures(n);
    int latest_day = 0;
    
    for (int i = 0; i < n; i++) {
        cin >> lectures[i].pay >> lectures[i].day;
        latest_day = max(latest_day, lectures[i].day); // 가장 늦은 강연일 저장
    }
    
    // 날짜 기준 내림차순 정렬
    sort(lectures.begin(), lectures.end(), cmp);
    
    priority_queue<int> pq; // Max Heap (우선순위 큐)
    int total_income = 0, idx = 0;
    
    // 가장 늦은 날짜부터 1일까지 강연 선택
    for (int d = latest_day; d >= 1; d--) {
        // 해당 날짜까지 가능한 강연 추가
        while (idx < n && lectures[idx].day >= d) {
            pq.push(lectures[idx].pay);
            idx++;
        }
        // 가장 높은 강연료 선택
        if (!pq.empty()) {
            total_income += pq.top();
            pq.pop();
        }
    }
    
    cout << total_income << '\n';
    return 0;
}
