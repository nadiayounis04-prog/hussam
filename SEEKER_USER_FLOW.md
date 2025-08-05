# SEEKER USER FLOW

## Complete Journey Map for Seeker Archetype

### 🚀 **ENTRY POINTS**
1. **Main Chambers Page** → `/chamber`
2. **Direct Seeker Chamber** → `/chamber/seeker`

---

### 📍 **STEP 1: Seeker Chamber Landing**
**URL:** `/chamber/seeker`
- **Content:** Seeker archetype overview, description, and characteristics
- **Action:** User learns about being a Seeker
- **Next:** User clicks "The Path" or "Breaker" button

---

### ⚡ **STEP 2: Breaker Page**
**URL:** `/chamber/seeker/breaker`
- **Content:**
  - "Path to Future Self: The Breaker"
  - Mythic language about becoming the Breaker
  - Field signs and breaker's law
  - 5-minute read with powerful motivation
- **Action:** User clicks "Begin the Breaker's Rite"
- **Next:** Redirects to Payment Gateway

---

### 🛤️ **STEP 3: The Path (Payment Gateway)**
**URL:** `/chamber/seeker/the-path`
- **Content:** 
  - "SEEKER — The Toll of Revelation"
  - Payment gateway with $27 fee
  - Motivational content about crossing thresholds
  - Benefits of taking the stage test
- **Action:** User clicks "Cross the Gate — $27"
- **Next:** Redirects to Stage Quiz

---

### 🧠 **STEP 4: Stage Quiz (20 Questions)**
**URL:** `/chamber/seeker/breaker/the-path/field-proof/free-walk`
- **Content:**
  - "Stage/Masks Diagnostic Quiz"
  - 20 questions to determine exact stage and mask
  - Progress bar showing completion
  - Seeker-themed purple/pink styling
- **Action:** User answers all 20 questions
- **Next:** Results page with diagnosis

---

### 📊 **STEP 5: Quiz Results**
**URL:** `/chamber/seeker/breaker/the-path/field-proof/free-walk/results`
- **Content:**
  - Stage diagnosis (Questioner, Edge Flincher, Edge Walker, Loop Burner, Breaker)
  - Mask identification
  - Stage progress bars for all 5 stages
  - "Your True Need" section
  - **Single Action Button:** "Recommended Rituals"
- **Action:** User clicks "Recommended Rituals"
- **Next:** Rituals page

---

### 🔮 **STEP 6: Recommended Rituals**
**URL:** `/chamber/seeker/rituals`
- **Content:**
  - Stage-specific rituals for progression
  - Practices to move from current stage to next
  - Ritual library with 30+ advanced practices
  - Seeker-specific ritual descriptions
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
- **5 stages:** Questioner → Edge Flincher → Edge Walker → Loop Burner → Breaker
- **Mask identification** for each stage
- **Progress tracking** across all stages
- **Personalized diagnosis** with specific needs

### **Ritual System**
- **Stage-specific practices** for progression
- **Advanced ritual library** with 30+ practices
- **Targeted evolution** from current to next stage

### **User Experience**
- **Beautiful UI** with purple/pink seeker theme
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
- **Primary Colors:** Purple (#9D4EDD) and Pink (#EC4899)
- **Background:** Black with subtle gradients
- **Animations:** Pulse effects, glowing borders
- **Typography:** Bold, mystical, motivational

---

## 🔧 **TECHNICAL IMPLEMENTATION**
- **Next.js routing** with dynamic archetype parameters
- **React state management** for quiz progress
- **URL parameters** for quiz results sharing
- **Conditional rendering** for seeker-specific content
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

*This flow creates a complete, engaging journey for Seeker users to discover their stage, understand their mask, and access targeted rituals for evolution.* 