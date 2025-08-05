# REBEL USER FLOW

## Complete Journey Map for Rebel Archetype

### 🚀 **ENTRY POINTS**
1. **Main Chambers Page** → `/chambers`
2. **Direct Rebel Chamber** → `/chamber/rebel`

---

### 📍 **STEP 1: Rebel Chamber Landing**
**URL:** `/chamber/rebel`
- **Content:** Rebel archetype overview, description, and characteristics
- **Action:** User learns about being a Rebel
- **Next:** User clicks "THE BREAKER" button

---

### ⚡ **STEP 2: Breaker Page**
**URL:** `/chamber/rebel/breaker`
- **Content:**
  - "THE CHAOS ENGINE"
  - Mythic language about becoming the Breaker
  - Field signs and breaker's law
  - 5-minute read with powerful motivation
- **Action:** User clicks "Begin the Breaker's Rite"
- **Next:** Redirects to Payment Gateway

---

### 🛤️ **STEP 3: The Path (Payment Gateway)**
**URL:** `/chamber/rebel/the-path`
- **Content:** 
  - "REBEL — The Toll of Disruption"
  - Payment gateway with $27 fee
  - Motivational content about crossing thresholds
  - Benefits of taking the stage test
- **Action:** User clicks "Cross the Gate — $27"
- **Next:** Redirects to Stage Quiz

---

### 🧠 **STEP 4: Stage Quiz (20 Questions)**
**URL:** `/chamber/rebel/breaker/the-path/field-proof/free-walk`
- **Content:**
  - "REBEL NODE - Stage/Masks Diagnostic Quiz"
  - 20 questions to determine exact stage and mask
  - Progress bar showing completion
  - Rebel-themed red/black styling
- **Action:** User answers all 20 questions
- **Next:** Results page with diagnosis

---

### 📊 **STEP 5: Quiz Results**
**URL:** `/chamber/rebel/breaker/the-path/field-proof/free-walk/results`
- **Content:**
  - Stage diagnosis (Chaos Seeker, Disruption Flincher, Disruption Walker, Loop Burner, Breaker)
  - Mask identification
  - Stage progress bars for all 5 stages
  - "Your True Need" section
  - **Single Action Button:** "Recommended Rituals"
- **Action:** User clicks "Recommended Rituals"
- **Next:** Rituals page

---

### 🔮 **STEP 6: Recommended Rituals**
**URL:** `/chamber/rebel/rituals`
- **Content:**
  - Stage-specific rituals for progression
  - Practices to move from current stage to next
  - Ritual library with 30+ advanced practices
  - Rebel-specific ritual descriptions
- **Action:** User practices rituals to evolve
- **Next:** User can retake quiz to measure progress

---

## 🔄 **ALTERNATIVE FLOWS**

### **Flow A: Standard Journey**
```
Chamber → Breaker → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Flow B: Direct Path (Alternative)**
```
Chamber → The Path → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Flow C: Retake Quiz**
```
Results → Stage Quiz → New Results → Rituals
```

---

## 🎯 **KEY FEATURES**

### **Payment Integration**
- **$27 fee** for stage quiz access
- **Payment gateway** with motivational content
- **Seamless redirect** to quiz after payment

### **Stage Detection**
- **5 stages:** Chaos Seeker → Disruption Flincher → Disruption Walker → Loop Burner → Breaker
- **Mask identification** for each stage
- **Progress tracking** across all stages
- **Personalized diagnosis** with specific needs

### **Ritual System**
- **Stage-specific practices** for progression
- **Advanced ritual library** with 30+ practices
- **Targeted evolution** from current to next stage

### **User Experience**
- **Beautiful UI** with red/black rebel theme
- **Responsive design** for all devices
- **Smooth navigation** between pages
- **Clear call-to-actions** at each step

---

## 📱 **MOBILE EXPERIENCE**
- **Responsive buttons** that stack on mobile
- **Readable text** at all screen sizes
- **Touch-friendly** quiz interface
- **Smooth animations** optimized for mobile

---

## 🎨 **VISUAL THEME**
- **Primary Colors:** Red (#dc2626) and Black (#000000)
- **Background:** Black with subtle gradients
- **Animations:** Pulse effects, glowing borders
- **Typography:** Bold, disruptive, motivational

---

## 🔧 **TECHNICAL IMPLEMENTATION**
- **Next.js routing** with dynamic archetype parameters
- **React state management** for quiz progress
- **URL parameters** for quiz results sharing
- **Conditional rendering** for rebel-specific content
- **Responsive CSS** with Tailwind

---

## 📈 **CONVERSION OPTIMIZATION**
- **Clear value proposition** at payment gateway
- **Single action button** on results page
- **Motivational language** throughout journey
- **Progress visualization** to show advancement
- **Personalized recommendations** based on results

---

## 🎯 **SUCCESS METRICS**
- **Payment conversion** from gateway to quiz
- **Quiz completion rate** (20 questions)
- **Ritual engagement** after results
- **Return visits** for progress tracking
- **Stage progression** over time

---

## ⚔️ **REBEL-SPECIFIC ELEMENTS**

### **Archetype Characteristics**
- **Name:** ⚔️ REBEL
- **Description:** Disruption Node - The Unbreakable Wall
- **Loop:** Opposition for its own sake, attachment to chaos, fear of order
- **Needs:** Choose disruption consciously, learn stillness, integrate discipline, own consequences

### **Rebel Stages**
1. **Chaos Seeker** - You seek disruption but without purpose. You oppose for opposition's sake.
2. **Disruption Flincher** - You sense opportunities to disrupt but hesitate to act.
3. **Disruption Walker** - You actively disrupt patterns but without full commitment.
4. **Loop Burner** - You burn cycles and accelerate endings through disruption.
5. **Breaker** - You end cycles and change eras through conscious disruption.

### **Rebel Rituals**
- **Social Disruption** - Test true power of challenge
- **Opposite Day** - Practice obedience, calm
- **Death Ritual** - Bury the old chaos-loop
- **Mirror Burn** - See self as source of disruption
- **Cold Water Override** - Discipline through discomfort
- **Body Mark** - Display the flaw, then erase

---

## ✅ **IMPLEMENTATION STATUS**

### **Completed Steps:**
1. ✅ **Chamber Landing** - Updated with Rebel-specific content and "THE BREAKER" button
2. ✅ **Breaker Page** - Configured with Rebel-specific content and "Begin the Breaker's Rite" button
3. ✅ **Payment Gateway** - Added Rebel-specific payment gateway with $27 fee and motivational content
4. ✅ **Stage Quiz** - 20-question quiz with Rebel-specific styling and progress tracking
5. ✅ **Results Page** - Complete results display with stage diagnosis and "Recommended Rituals" button
6. ✅ **Rituals Page** - Rebel-specific rituals and practices for stage progression

### **Flow Sequence:**
```
Chamber Landing → Breaker Page → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Key Features Implemented:**
- ✅ Rebel-specific styling and branding throughout
- ✅ Payment gateway with motivational content
- ✅ 20-question stage/mask diagnostic quiz
- ✅ Results page with stage diagnosis and progress tracking
- ✅ Single action button flow to rituals
- ✅ Responsive design for all devices
- ✅ Smooth navigation between all steps

---

*This flow creates a complete, engaging journey for Rebel users to discover their stage, understand their mask, and access targeted rituals for evolution through conscious disruption.* 